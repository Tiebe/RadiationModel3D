
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Moscovium290 : RadioactiveSubstance
    {
        public override string name { get; } = "Moscovium290";
        public override double halfLife { get; } = 0.84d;
        public override double atomicWeight { get; } = 290.19623d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Nihonium286() } },

        };
    }
}
    
    