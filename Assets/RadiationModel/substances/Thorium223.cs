using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium223";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 223.02081d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium219() }, { 1.0d, new AlphaParticle(8588002.09) }, { 0.0007000000000000001d, new GammaParticle(38200.0, 0.03246) }, { 0.0003d, new GammaParticle(52000.0, 0.02384) }, { 0.005d, new GammaParticle(88000.0, 0.01409) }, { 0.009000000000000001d, new GammaParticle(97140.0, 0.01276) }, { 0.016d, new GammaParticle(113740.0, 0.0109) }, { 0.057999999999999996d, new GammaParticle(140010.0, 0.00886) }, { 0.037000000000000005d, new GammaParticle(151990.0, 0.00816) }, { 0.0006d, new GammaParticle(168800.0, 0.00735) }, { 0.0002d, new GammaParticle(188400.0, 0.00658) }, { 0.003d, new GammaParticle(252800.0, 0.0049) }, { 0.006999999999999999d, new GammaParticle(264700.0, 0.00468) }, { 0.001d, new GammaParticle(268000.0, 0.00463) }, { 0.0004d, new GammaParticle(276100.0, 0.00449) }, { 0.002d, new GammaParticle(293000.0, 0.00423) }, { 0.002d, new GammaParticle(305000.0, 0.00407) }, { 0.0006d, new GammaParticle(318800.0, 0.00389) }, { 0.0002d, new GammaParticle(320600.0, 0.00387) }, { 0.002d, new GammaParticle(331300.0, 0.00374) }, { 0.0002d, new GammaParticle(353000.0, 0.00351) }, { 0.001d, new GammaParticle(356900.0, 0.00347) }, { 0.0006d, new GammaParticle(401700.0, 0.00309) }, { 0.0003d, new GammaParticle(421700.0, 0.00294) }, { 0.30299076912d, new GammaParticle(14920.0, 0.0831) }, { 0.14131657158387617d, new GammaParticle(85432.0, 0.01451) }, { 0.23083399474661254d, new GammaParticle(88471.0, 0.01401) }, { 0.08098758559451148d, new GammaParticle(100119.0, 0.01238) }, { 0.10755151366951125d, new GammaParticle(101370.0, 0.01223) }, { 0.02656392807499977d, new GammaParticle(102948.0, 0.01204) } } },

        };
    }
}
    