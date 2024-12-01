using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hassium278 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium278";
        public override double halfLife { get; } = 1140.0d;
        public override double atomicWeight { get; } = 278.15375d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new AlphaParticle(255371201353.41998)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    