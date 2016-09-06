using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleMVVM
{
    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        readonly Predicate<object> canExecute;


        public RelayCommand(Action<object> actionToExecute)
            : this(actionToExecute, null)
        {
        }

        public RelayCommand(Action<object> actionToExecute, Predicate<object> canExecute)
        {
            if (actionToExecute == null)
                throw new ArgumentNullException("actionToExecute");

            this.execute = actionToExecute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
