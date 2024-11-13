
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium222";
        public override double halfLife { get; } = 0.00224d;
        public override double atomicWeight { get; } = 222.01847d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Radium218() } },

        };
    }
}
    
    