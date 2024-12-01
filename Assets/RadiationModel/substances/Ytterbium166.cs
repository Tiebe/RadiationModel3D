using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium166";
        public override double halfLife { get; } = 204120.0d;
        public override double atomicWeight { get; } = 165.93388d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium166()), new(0.1555d, new GammaParticle(82290.0, 0.01507)), new(0.34354747500000005d, new GammaParticle(8215.0, 0.15092)), new(0.39365160047457415d, new GammaParticle(49773.0, 0.02491)), new(0.6950063567700815d, new GammaParticle(50742.0, 0.02443)), new(0.22723574821852735d, new GammaParticle(57612.0, 0.02152)), new(0.2863170427553445d, new GammaParticle(58257.0, 0.02128)), new(0.05908129453681712d, new GammaParticle(59034.0, 0.021)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    