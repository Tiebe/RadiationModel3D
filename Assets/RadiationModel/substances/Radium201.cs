
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium201 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium201";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 201.01281d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Radon197() } },

        };
    }
}
    
    