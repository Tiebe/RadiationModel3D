using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen21 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen21";
        public override double halfLife { get; } = 3.42d;
        public override double atomicWeight { get; } = 21.00865d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fluorine21() }, { 1.0d, new BetaParticle(-1, 4054800.0) }, { 0.147744d, new GammaParticle(279920.0, 0.00443) }, { 0.057912d, new GammaParticle(933200.0, 0.00133) }, { 0.098496d, new GammaParticle(1450500.0, 0.00085) }, { 0.04104d, new GammaParticle(1729200.0, 0.00072) }, { 0.456d, new GammaParticle(1730280.0, 0.00072) }, { 0.113088d, new GammaParticle(1754740.0, 0.00071) }, { 0.141816d, new GammaParticle(1787160.0, 0.00069) }, { 0.0684d, new GammaParticle(1884010.0, 0.00066) }, { 0.05244d, new GammaParticle(3179430.0, 0.00039) }, { 0.02964d, new GammaParticle(3459380.0, 0.00036) }, { 0.15412800000000001d, new GammaParticle(3517400.0, 0.00035) }, { 0.047424d, new GammaParticle(4572200.0, 0.00027) }, { 0.052896d, new GammaParticle(4583500.0, 0.00027) } } },

        };
    }
}
    