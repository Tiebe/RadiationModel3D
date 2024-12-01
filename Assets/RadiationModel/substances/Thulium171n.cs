using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium171n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium171n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 170.93823d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium171()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    