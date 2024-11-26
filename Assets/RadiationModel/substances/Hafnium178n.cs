using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium178n : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium178n";
        public override double halfLife { get; } = 978264705.21235d;
        public override double atomicWeight { get; } = 177.94633d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium178()), new(6.7752e-08d, new GammaParticle(12700.0, 0.09763)), new(0.638939d, new GammaParticle(88873.0, 0.01395)), new(0.17596699999999998d, new GammaParticle(93193.0, 0.0133)), new(0.8073779999999999d, new GammaParticle(213434.0, 0.00581)), new(0.64929d, new GammaParticle(216668.0, 0.00572)), new(5.646e-05d, new GammaParticle(230800.0, 0.00537)), new(0.0915593d, new GammaParticle(237430.0, 0.00522)), new(0.16655699999999998d, new GammaParticle(257645.0, 0.00481)), new(0.0148678d, new GammaParticle(277402.0, 0.00447)), new(0.1001224d, new GammaParticle(296812.0, 0.00418)), new(0.00014115000000000002d, new GammaParticle(309400.0, 0.00401)), new(0.941d, new GammaParticle(325560.0, 0.00381)), new(1.6938e-05d, new GammaParticle(343300.0, 0.00361)), new(0.9654659999999999d, new GammaParticle(426360.0, 0.00291)), new(0.16561599999999999d, new GammaParticle(454048.0, 0.00273)), new(0.701045d, new GammaParticle(495013.0, 0.0025)), new(7.528e-06d, new GammaParticle(515100.0, 0.00241)), new(0.092218d, new GammaParticle(535038.0, 0.00232)), new(0.886422d, new GammaParticle(574219.0, 0.00216)), new(5.8342000000000005e-05d, new GammaParticle(587000.0, 0.00211)), new(2.4466000000000003e-05d, new GammaParticle(601100.0, 0.00206)), new(0.52d, new GammaParticle(9114.0, 0.13604)), new(0.222d, new GammaParticle(54608.0, 0.0227)), new(0.389d, new GammaParticle(55786.0, 0.02222)), new(0.128d, new GammaParticle(63333.0, 0.01958)), new(0.163d, new GammaParticle(64057.0, 0.01936)), new(0.0342d, new GammaParticle(64935.0, 0.01909)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    