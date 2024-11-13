
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum180q : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum180q";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 179.95195d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Tantalum180() } },

        };
    }
}
    
    