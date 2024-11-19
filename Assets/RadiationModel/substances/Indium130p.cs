using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium130p : RadioactiveSubstance
    {
        public override string name { get; } = "Indium130p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 129.92537d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((388300.0, 0.00319)), new Indium130() } },

        };
    }
}
    
    