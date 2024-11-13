
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium219";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 219.01995d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Actinium215() } },

        };
    }
}
    
    