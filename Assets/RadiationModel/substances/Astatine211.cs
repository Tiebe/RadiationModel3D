using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine211 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine211";
        public override double halfLife { get; } = 25970.4d;
        public override double atomicWeight { get; } = 210.9875d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.5820000000000001d, new List<RadioactiveSubstance> { new Polonium211() } },
            { 0.418d, new List<RadioactiveSubstance> { new AlphaParticle(7002447.4), new Bismuth207() } },

        };
    }
}
    
    