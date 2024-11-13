
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

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Actinium210() } },

        };
    }
}
    
    