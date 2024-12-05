using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium176q : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium176q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 175.94663d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    