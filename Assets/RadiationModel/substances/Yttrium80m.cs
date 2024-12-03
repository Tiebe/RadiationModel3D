using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium80m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium80m";
        public override double halfLife { get; } = 4.8d;
        public override double atomicWeight { get; } = 79.9346d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.81d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium80()) } },
            { 0.19d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium80()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.2d, new GammaParticle(385900.0, 0.00321)), new(0.0101d, new GammaParticle(428400.0, 0.00289)), new(0.0101d, new GammaParticle(594800.0, 0.00208)), new(0.02d, new GammaParticle(756200.0, 0.00164)), new(0.0101d, new GammaParticle(1142100.0, 0.00109)), new(0.0121d, new GammaParticle(1350400.0, 0.00092)), new(0.5682d, new GammaParticle(511000.0, 0.00243)), new(1.6e-05d, new GammaParticle(1890.0, 0.656)), new(0.0001d, new GammaParticle(14098.0, 0.08794)), new(0.00018999999999999998d, new GammaParticle(14165.0, 0.08753)), new(5e-05d, new GammaParticle(15898.0, 0.07799)), new(5e-05d, new GammaParticle(15955.0, 0.07771)), new(5.999999999999999e-06d, new GammaParticle(16085.0, 0.07708)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    