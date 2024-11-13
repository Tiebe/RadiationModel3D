
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium248";
        public override double halfLife { get; } = 28814400.0d;
        public override double atomicWeight { get; } = 248.07218d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Curium244() } },

            { 2.8999999999999997e-05d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    