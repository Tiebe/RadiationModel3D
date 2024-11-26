using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead188 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead188";
        public override double halfLife { get; } = 25.5d;
        public override double atomicWeight { get; } = 187.98088d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.915d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury188() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.085d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury184() }, { 1.0d, new AlphaParticle(7131002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    