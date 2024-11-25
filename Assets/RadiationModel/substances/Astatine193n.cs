using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine193n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine193n";
        public override double halfLife { get; } = 0.027d;
        public override double atomicWeight { get; } = 192.99997d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.76d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine193() } } },
            { 0.24d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth189() }, { 1.0d, new AlphaParticle(8637002.09) }, { 0.12d, new GammaParticle(357600.0, 0.00347) }, { 0.036224210640000004d, new GammaParticle(12904.0, 0.09608) }, { 0.024951272125555483d, new GammaParticle(74815.0, 0.01657) }, { 0.04174547787444451d, new GammaParticle(77108.0, 0.01608) }, { 0.014299456355283308d, new GammaParticle(87388.0, 0.01419) }, { 0.018675090000000002d, new GammaParticle(88458.0, 0.01402) }, { 0.004375633644716693d, new GammaParticle(89784.0, 0.01381) } } },

        };
    }
}
    