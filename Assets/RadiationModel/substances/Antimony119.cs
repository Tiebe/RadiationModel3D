using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony119 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony119";
        public override double halfLife { get; } = 137484.0d;
        public override double atomicWeight { get; } = 118.90394d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin119()), new(0.165d, new GammaParticle(23870.0, 0.05194)), new(0.117511556d, new GammaParticle(3753.0, 0.33036)), new(0.20879953870172124d, new GammaParticle(25044.0, 0.04951)), new(0.3907908266923474d, new GammaParticle(25271.0, 0.04906)), new(0.11050094787462951d, new GammaParticle(28579.0, 0.04338)), new(0.13226963460593152d, new GammaParticle(28810.0, 0.04304)), new(0.02176868673130201d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    