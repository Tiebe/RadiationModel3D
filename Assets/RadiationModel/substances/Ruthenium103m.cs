using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium103m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium103m";
        public override double halfLife { get; } = 0.00169d;
        public override double atomicWeight { get; } = 102.90657d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium103() }, { 0.0030849d, new GammaParticle(2700.0, 0.4592) }, { 0.0011283999999999999d, new GammaParticle(24000.0, 0.05166) }, { 0.91d, new GammaParticle(210700.0, 0.00588) }, { 0.05096d, new GammaParticle(213400.0, 0.00581) }, { 0.042034433532d, new GammaParticle(2737.0, 0.45299) }, { 0.16394574310074397d, new GammaParticle(19150.0, 0.06474) }, { 0.3110924916522656d, new GammaParticle(19279.0, 0.06431) }, { 0.0836018235860503d, new GammaParticle(21736.0, 0.05704) }, { 0.09714531900699046d, new GammaParticle(21875.0, 0.05668) }, { 0.013543495420940148d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    