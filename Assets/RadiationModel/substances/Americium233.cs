using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium233";
        public override double halfLife { get; } = 192.0d;
        public override double atomicWeight { get; } = 233.04647d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.955d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium233() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.045d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium229() }, { 1.0d, new AlphaParticle(8087002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    