using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium162m";
        public override double halfLife { get; } = 0.077d;
        public override double atomicWeight { get; } = 161.97608d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.91d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum158() }, { 1.0d, new AlphaParticle(7437002.09) } } },
            { 0.09d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum162() }, { 1.0d, new BetaParticle(1, 8750000.0) } } },

        };
    }
}
    