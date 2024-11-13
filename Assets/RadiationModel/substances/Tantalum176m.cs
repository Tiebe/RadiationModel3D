
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum176m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum176m";
        public override double halfLife { get; } = 0.00108d;
        public override double atomicWeight { get; } = 175.94496d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Tantalum176() } },

        };
    }
}
    
    