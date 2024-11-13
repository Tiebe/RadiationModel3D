
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium220 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium220";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 220.02177d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Actinium216() } },

        };
    }
}
    
    