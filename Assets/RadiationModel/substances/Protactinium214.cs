using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium214";
        public override double halfLife { get; } = 0.017d;
        public override double atomicWeight { get; } = 214.02089d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium210() }, { 1.0d, new AlphaParticle(9297002.09) } } },

        };
    }
}
    