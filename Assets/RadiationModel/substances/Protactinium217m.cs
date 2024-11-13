
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

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.73d, new List<RadioactiveSubstance> { new AlphaParticle(), new Actinium213() } },

        };
    }
}
    
    