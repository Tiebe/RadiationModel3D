using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver105m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver105m";
        public override double halfLife { get; } = 433.8d;
        public override double atomicWeight { get; } = 104.90655d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9965999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver105()), new(4.35e-05d, new GammaParticle(25480.0, 0.04866)), new(0.04653952578d, new GammaParticle(3218.0, 0.38528)) } },
            { 0.0034000000000000002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium105()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.8000000000000001e-06d, new GammaParticle(38770.0, 0.03198)), new(6.5e-08d, new GammaParticle(64072.0, 0.01935)), new(3.3e-07d, new GammaParticle(216100.0, 0.00574)), new(5.7e-05d, new GammaParticle(280530.0, 0.00442)), new(0.0003d, new GammaParticle(306290.0, 0.00405)), new(0.0015d, new GammaParticle(319230.0, 0.00388)), new(2.6e-07d, new GammaParticle(344610.0, 0.0036)), new(2e-05d, new GammaParticle(370000.0, 0.00335)), new(0.00014000000000000001d, new GammaParticle(442250.0, 0.0028)), new(8.2e-06d, new GammaParticle(475100.0, 0.00261)), new(4.2e-05d, new GammaParticle(487100.0, 0.00255)), new(6.9e-05d, new GammaParticle(560790.0, 0.00221)), new(3.1e-05d, new GammaParticle(610100.0, 0.00203)), new(3.3e-06d, new GammaParticle(629700.0, 0.00197)), new(2.6e-05d, new GammaParticle(649200.0, 0.00191)), new(6.5e-06d, new GammaParticle(656500.0, 0.00189)), new(4.4e-06d, new GammaParticle(781300.0, 0.00159)), new(3.3e-06d, new GammaParticle(818000.0, 0.00152)), new(9.499999999999999e-05d, new GammaParticle(929300.0, 0.00133)), new(6.5e-06d, new GammaParticle(1072200.0, 0.00116)), new(5.4000000000000005e-05d, new GammaParticle(1098390.0, 0.00113)), new(9.8e-06d, new GammaParticle(511000.0, 0.00243)), new(0.000178d, new GammaParticle(3053.0, 0.40611)), new(0.0007000000000000001d, new GammaParticle(21020.0, 0.05898)), new(0.00132d, new GammaParticle(21177.0, 0.05855)), new(0.00035999999999999997d, new GammaParticle(23904.0, 0.05187)), new(0.00043d, new GammaParticle(24070.0, 0.05151)), new(6.2e-05d, new GammaParticle(24297.0, 0.05103)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    