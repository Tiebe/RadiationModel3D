
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium225";
        public override double halfLife { get; } = 1.71d;
        public override double atomicWeight { get; } = 225.02615d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Actinium221() } },

        };
    }
}
    
    