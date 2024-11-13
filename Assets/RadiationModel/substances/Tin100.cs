
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin100 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin100";
        public override double halfLife { get; } = 1.18d;
        public override double atomicWeight { get; } = 99.93865d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium100() } },

        };
    }
}
    
    