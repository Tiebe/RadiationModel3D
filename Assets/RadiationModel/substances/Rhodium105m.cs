using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium105m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium105m";
        public override double halfLife { get; } = 42.8d;
        public override double atomicWeight { get; } = 104.90583d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium105()), new(0.2024d, new GammaParticle(129782.0, 0.00955)), new(0.036521667d, new GammaParticle(2892.0, 0.42871)), new(0.11928744192785093d, new GammaParticle(20073.0, 0.06177)), new(0.22583764090846448d, new GammaParticle(20215.0, 0.06133)), new(0.06132926000315999d, new GammaParticle(22806.0, 0.05436)), new(0.07150991716368454d, new GammaParticle(22957.0, 0.05401)), new(0.010180657160524558d, new GammaParticle(23170.0, 0.05351)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    