using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavod
{
    public class User :IBindableComponent
    {
        private bool disposedValue;

        [DisplayName("comp_id")]
        [Browsable(false)]
        public int comp_id { get; internal set; }

        public string name { get; internal set; }
        [DisplayName("name")]
        public DateTime startdate { get; internal set; }
        public DateTime enddate { get; internal set; }

        [DisplayName("idceli")]
        [Browsable(false)]
        public int idceli { get; internal set; }

        [DisplayName("otvid")]
        [Browsable(false)]
        public int otvid { get; internal set; }


        [DisplayName("idcelilist")]
        [Browsable(false)]
        public int idcelilist { get; internal set; }

        ControlBindingsCollection IBindableComponent.DataBindings => throw new NotImplementedException();

        BindingContext IBindableComponent.BindingContext { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ISite IComponent.Site { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        event EventHandler IComponent.Disposed
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты)
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                disposedValue = true;
            }
        }

        // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
        // ~User()
        // {
        //     // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        void IDisposable.Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
