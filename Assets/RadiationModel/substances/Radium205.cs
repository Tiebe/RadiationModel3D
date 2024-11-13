
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium205 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium205";
        public override double halfLife { get; } = 0.22d;
        public override double atomicWeight { get; } = 205.00623d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Radon201() } },

        };
    }
}
    
    