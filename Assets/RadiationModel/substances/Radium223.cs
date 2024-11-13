
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium223";
        public override double halfLife { get; } = 988001.28d;
        public override double atomicWeight { get; } = 223.0185d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Radon219() } },

            { 8.9e-10d, new List<RadioactiveSubstance> { new Carbon14(), new Lead209() } },

        };
    }
}
    
    