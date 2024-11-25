using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium14 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium14";
        public override double halfLife { get; } = 0.00435d;
        public override double atomicWeight { get; } = 14.04289d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron14() }, { 1.0d, new BetaParticle(-1, 8143000.0) } } },
            { 0.81d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron14() }, { 1.0d, new BetaParticle(-1, 8143000.0) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron12() }, { 1.0d, new BetaParticle(-1, 944784403.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    