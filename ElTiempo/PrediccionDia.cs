using System.Collections.ObjectModel;
using System.ComponentModel;

public class PrediccionDia : INotifyPropertyChanged
{
    private void NotifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


    private string _dia;
    public string Dia
    {
        get
        {
            return _dia;
        }
        set
        {
            _dia = value;
            NotifyPropertyChanged("Dia");
        }
    }

    private string _prediccion;
    public string Prediccion
    {
        get
        {
            return _prediccion;
        }
        set
        {
            _prediccion = value;
            NotifyPropertyChanged("Prediccion");
        }
    }

    private int _minimaFarenheit;
    public int MinimaFarenheit
    {
        get
        {
            return _minimaFarenheit;
        }
        set
        {
            _minimaFarenheit = value;
            NotifyPropertyChanged("MinimaFarenheit");
        }
    }

    private int _maximaFarenheit;

    public event PropertyChangedEventHandler PropertyChanged;

    public int MaximaFarenheit
    {
        get
        {
            return _maximaFarenheit;
        }
        set
        {
            _maximaFarenheit = value;
            NotifyPropertyChanged("MaximaFarenheit");
        }
    }

    public PrediccionDia(string dia, string prediccion, int minima, int maxima)
    {
        this.Dia = dia;
        this.Prediccion = prediccion;
        this.MinimaFarenheit = minima;
        this.MaximaFarenheit = maxima;
    }

    public static ObservableCollection<PrediccionDia> ObtenerDatos()
    {
        ObservableCollection<PrediccionDia> resultado = new ObservableCollection<PrediccionDia>();

        resultado.Add(new PrediccionDia("Lunes", "sol", 44, 60));
        resultado.Add(new PrediccionDia("Martes", "nubes", 55, 70));
        resultado.Add(new PrediccionDia("Miércoles", "sol", 35, 55));
        resultado.Add(new PrediccionDia("Jueves", "nubes", 48, 65));
        resultado.Add(new PrediccionDia("Viernes", "lluvia", 37, 50));
        resultado.Add(new PrediccionDia("Sábado", "nubes", 30, 50));
        resultado.Add(new PrediccionDia("Domingo", "nieve", 28, 40));

        return resultado;
    }
}
