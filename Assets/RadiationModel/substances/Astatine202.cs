
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine202 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine202";
        public override double halfLife { get; } = 184.0d;
        public override double atomicWeight { get; } = 201.98863d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.88d, new List<RadioactiveSubstance> { new BetaParticle(), new Polonium202() } },

            { 0.12d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth198() } },

        };
    }
}
    
    