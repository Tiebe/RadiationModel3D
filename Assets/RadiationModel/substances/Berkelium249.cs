
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium249";
        public override double halfLife { get; } = 28270080.0d;
        public override double atomicWeight { get; } = 249.07498d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Californium249() } },

            { 1.4499999999999998e-05d, new List<RadioactiveSubstance> { new AlphaParticle(), new Americium245() } },

            { 4.699999999999999e-10d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    