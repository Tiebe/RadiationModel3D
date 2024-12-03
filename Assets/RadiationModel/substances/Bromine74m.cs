using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bromine74m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine74m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 73.92993d;

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
    