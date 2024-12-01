using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium224";
        public override double halfLife { get; } = 313770.24d;
        public override double atomicWeight { get; } = 224.02021d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon220()), new(1.0d, new AlphaParticle(6810802.09)), new(0.040999999999999995d, new GammaParticle(240986.0, 0.00514)), new(6.2e-05d, new GammaParticle(292700.0, 0.00424)), new(2.2000000000000003e-05d, new GammaParticle(404200.0, 0.00307)), new(3e-05d, new GammaParticle(422040.0, 0.00294)), new(5.4000000000000005e-05d, new GammaParticle(645500.0, 0.00192)), new(0.00370883569840672d, new GammaParticle(14088.0, 0.08801)), new(0.0012928598739765334d, new GammaParticle(81070.0, 0.01529)), new(0.0021327282645604313d, new GammaParticle(83789.0, 0.0148)), new(0.000739615620820481d, new GammaParticle(94878.0, 0.01307)), new(0.000976292619483035d, new GammaParticle(96054.0, 0.01291)), new(0.00023667699866255392d, new GammaParticle(97530.0, 0.01271)) } },
            { 4.0000000000000004e-11d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    