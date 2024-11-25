using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin104 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin104";
        public override double halfLife { get; } = 20.8d;
        public override double atomicWeight { get; } = 103.92311d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium104() }, { 1.0d, new BetaParticle(1, 6170700.0) }, { 0.0975d, new GammaParticle(93200.0, 0.0133) }, { 0.75d, new GammaParticle(132700.0, 0.00934) }, { 0.0975d, new GammaParticle(148100.0, 0.00837) }, { 0.0675d, new GammaParticle(154700.0, 0.00801) }, { 0.0075d, new GammaParticle(169900.0, 0.0073) }, { 0.0525d, new GammaParticle(302800.0, 0.00409) }, { 0.135d, new GammaParticle(342300.0, 0.00362) }, { 0.18d, new GammaParticle(401200.0, 0.00309) }, { 0.075d, new GammaParticle(512000.0, 0.00242) }, { 0.1125d, new GammaParticle(644600.0, 0.00192) }, { 0.09d, new GammaParticle(703500.0, 0.00176) }, { 0.09d, new GammaParticle(894900.0, 0.00139) }, { 0.05025d, new GammaParticle(912600.0, 0.00136) }, { 0.45d, new GammaParticle(912600.0, 0.00136) }, { 0.01125d, new GammaParticle(1045000.0, 0.00119) }, { 0.03d, new GammaParticle(1156300.0, 0.00107) }, { 0.09d, new GammaParticle(1215300.0, 0.00102) }, { 0.0315d, new GammaParticle(1273500.0, 0.00097) }, { 0.165d, new GammaParticle(1407300.0, 0.00088) }, { 0.0165d, new GammaParticle(1425400.0, 0.00087) }, { 0.015d, new GammaParticle(1845800.0, 0.00067) }, { 1.284d, new GammaParticle(511000.0, 0.00243) }, { 0.0388557063972d, new GammaParticle(3571.0, 0.3472) }, { 0.1288339059574509d, new GammaParticle(24001.0, 0.05166) }, { 0.24171464532354764d, new GammaParticle(24209.0, 0.05121) }, { 0.06781972644453906d, new GammaParticle(27367.0, 0.0453) }, { 0.08070547446900146d, new GammaParticle(27581.0, 0.04495) }, { 0.01288574802446242d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    