using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic73 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic73";
        public override double halfLife { get; } = 6937920.0d;
        public override double atomicWeight { get; } = 72.92383d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium73() }, { 0.00094d, new GammaParticle(13284.5, 0.09333) }, { 0.106d, new GammaParticle(53437.0, 0.0232) }, { 0.0457543128d, new GammaParticle(1221.0, 1.01543) }, { 0.30966040408376405d, new GammaParticle(9856.0, 0.1258) }, { 0.6013991145538241d, new GammaParticle(9887.0, 0.1254) }, { 0.13451945338787868d, new GammaParticle(11026.0, 0.11245) }, { 0.13747888136241204d, new GammaParticle(11038.0, 0.11232) }, { 0.0029594279745333314d, new GammaParticle(11099.0, 0.11171) } } },

        };
    }
}
    