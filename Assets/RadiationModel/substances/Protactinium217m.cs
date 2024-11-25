using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium217m : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium217m";
        public override double halfLife { get; } = 0.00108d;
        public override double atomicWeight { get; } = 217.02031d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.73d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium213() }, { 1.0d, new AlphaParticle(11371002.09) } } },
            { 0.27d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium217() } } },

        };
    }
}
    