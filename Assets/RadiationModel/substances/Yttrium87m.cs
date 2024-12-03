using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium87m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium87m";
        public override double halfLife { get; } = 48132.0d;
        public override double atomicWeight { get; } = 86.91128d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9843000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium87()), new(0.7805d, new GammaParticle(380790.0, 0.00326)), new(0.00578949635215d, new GammaParticle(2027.0, 0.61166)), new(0.03338069005477254d, new GammaParticle(14883.0, 0.08331)), new(0.06400899339361944d, new GammaParticle(14958.0, 0.08289)), new(0.016071865159585252d, new GammaParticle(16803.0, 0.07379)), new(0.018289782551608017d, new GammaParticle(16880.0, 0.07345)), new(0.0022179173920227647d, new GammaParticle(17011.0, 0.07288)) } },
            { 0.015700000000000002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium87()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.015d, new GammaParticle(511000.0, 0.00243)), new(0.000229105438356d, new GammaParticle(1890.0, 0.656)), new(0.0014434639790043052d, new GammaParticle(14098.0, 0.08794)), new(0.0027732257041389145d, new GammaParticle(14165.0, 0.08753)), new(0.0006847456255369743d, new GammaParticle(15898.0, 0.07799)), new(0.0007737625568567807d, new GammaParticle(15955.0, 0.07771)), new(8.901693131980665e-05d, new GammaParticle(16085.0, 0.07708)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    