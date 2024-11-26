using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum159m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum159m";
        public override double halfLife { get; } = 0.56d;
        public override double atomicWeight { get; } = 158.9631d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.55d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium155() }, { 1.0d, new AlphaParticle(6767002.09) } } },
            { 0.45d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium159() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    