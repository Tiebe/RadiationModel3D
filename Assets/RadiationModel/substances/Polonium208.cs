using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium208";
        public override double halfLife { get; } = 91451971.47437d;
        public override double atomicWeight { get; } = 207.98125d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99996d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead204()), new(1.0d, new AlphaParticle(6237602.09)) } },
            { 4e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead208()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(2.7e-07d, new GammaParticle(31800.0, 0.03899)), new(3.4e-06d, new GammaParticle(63130.0, 0.01964)), new(2.27e-05d, new GammaParticle(291810.0, 0.00425)), new(5e-06d, new GammaParticle(538390.0, 0.0023)), new(1.38e-05d, new GammaParticle(570130.0, 0.00217)), new(1.07e-05d, new GammaParticle(601520.0, 0.00206)), new(7.4e-06d, new GammaParticle(861820.0, 0.00144)), new(5e-07d, new GammaParticle(925110.0, 0.00134)), new(2.8951154085722e-05d, new GammaParticle(12904.0, 0.09608)), new(1.1124513970896836e-05d, new GammaParticle(74815.0, 0.01657)), new(1.8612203397853164e-05d, new GammaParticle(77108.0, 0.01608)), new(6.375406480283307e-06d, new GammaParticle(87388.0, 0.01419)), new(8.32628086325e-06d, new GammaParticle(88458.0, 0.01402)), new(1.950874382966692e-06d, new GammaParticle(89784.0, 0.01381)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    