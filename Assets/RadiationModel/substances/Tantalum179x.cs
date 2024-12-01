using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum179x : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum179x";
        public override double halfLife { get; } = 0.0541d;
        public override double atomicWeight { get; } = 178.94877d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum179()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    