using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead187m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead187m";
        public override double halfLife { get; } = 18.3d;
        public override double atomicWeight { get; } = 186.98393d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury187() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury183() }, { 1.0d, new AlphaParticle(7434002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    