using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium109";
        public override double halfLife { get; } = 0.905d;
        public override double atomicWeight { get; } = 108.92025d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6455000.0), new Ruthenium109() } },

        };
    }
}
    
    