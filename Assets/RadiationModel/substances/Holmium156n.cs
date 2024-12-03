using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium156n : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium156n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 155.92989d;

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
    