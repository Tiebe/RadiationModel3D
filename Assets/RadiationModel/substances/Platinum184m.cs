using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum184m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum184m";
        public override double halfLife { get; } = 0.00101d;
        public override double atomicWeight { get; } = 183.9619d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum184() }, { 0.0032d, new GammaParticle(49000.0, 0.0253) }, { 0.058499999999999996d, new GammaParticle(112000.0, 0.01107) }, { 0.0546d, new GammaParticle(118000.0, 0.01051) }, { 0.4914d, new GammaParticle(162400.0, 0.00763) }, { 0.78d, new GammaParticle(272200.0, 0.00455) }, { 0.011699999999999999d, new GammaParticle(286500.0, 0.00433) }, { 0.5538000000000001d, new GammaParticle(360800.0, 0.00344) }, { 0.0546d, new GammaParticle(389500.0, 0.00318) }, { 0.039d, new GammaParticle(424000.0, 0.00292) }, { 0.5226d, new GammaParticle(431000.0, 0.00288) }, { 0.18719999999999998d, new GammaParticle(439000.0, 0.00282) }, { 0.0858d, new GammaParticle(486500.0, 0.00255) }, { 0.0429d, new GammaParticle(554000.0, 0.00224) }, { 0.49920000000000003d, new GammaParticle(610100.0, 0.00203) }, { 0.011699999999999999d, new GammaParticle(676000.0, 0.00183) }, { 0.01482d, new GammaParticle(775000.0, 0.0016) }, { 0.05694d, new GammaParticle(796000.0, 0.00156) }, { 0.03354d, new GammaParticle(839000.0, 0.00148) }, { 0.04524d, new GammaParticle(867000.0, 0.00143) }, { 0.05772d, new GammaParticle(930000.0, 0.00133) }, { 0.06318d, new GammaParticle(1065000.0, 0.00116) }, { 0.156d, new GammaParticle(1235000.0, 0.001) }, { 0.294077089303998d, new GammaParticle(11070.0, 0.112) }, { 0.10303168313644218d, new GammaParticle(65122.0, 0.01904) }, { 0.17612253527596952d, new GammaParticle(66832.0, 0.01855) }, { 0.059260576692525956d, new GammaParticle(75821.0, 0.01635) }, { 0.0762091016265884d, new GammaParticle(76725.0, 0.01616) }, { 0.016948524934062424d, new GammaParticle(77832.0, 0.01593) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    