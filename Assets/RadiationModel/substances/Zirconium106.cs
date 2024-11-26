using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium106";
        public override double halfLife { get; } = 0.18d;
        public override double atomicWeight { get; } = 105.93693d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium106() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium106() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    