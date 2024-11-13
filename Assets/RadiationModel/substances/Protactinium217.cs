
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium217";
        public override double halfLife { get; } = 0.0038d;
        public override double atomicWeight { get; } = 217.01831d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Actinium213() } },

        };
    }
}
    
    