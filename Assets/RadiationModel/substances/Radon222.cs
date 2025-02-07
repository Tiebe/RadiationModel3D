using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon222 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon222";
        public override double halfLife { get; } = 330238.08d;
        public override double atomicWeight { get; } = 222.01758d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium218()), new(1.0d, new AlphaParticle(6612302.09)), new(0.0007599999999999999d, new GammaParticle(510000.0, 0.00243)), new(7.420888748000001e-06d, new GammaParticle(13292.0, 0.09328)), new(4.571827305332138e-06d, new GammaParticle(76862.0, 0.01613)), new(7.613367702468174e-06d, new GammaParticle(79290.0, 0.01564)), new(2.6210716950417152e-06d, new GammaParticle(89837.0, 0.0138)), new(3.4362249921996883e-06d, new GammaParticle(90941.0, 0.01363)), new(8.151532971579735e-07d, new GammaParticle(92315.0, 0.01343)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    