using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dubnium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium257";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 257.10752d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.94d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lawrencium253()), new(1.0d, new AlphaParticle(10227002.09)) } },
            { 0.06d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    