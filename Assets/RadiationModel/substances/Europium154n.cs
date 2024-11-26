using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium154n : RadioactiveSubstance
    {
        public override string name { get; } = "Europium154n";
        public override double halfLife { get; } = 2778.0d;
        public override double atomicWeight { get; } = 153.92314d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium154()), new(1.8000000000000001e-06d, new GammaParticle(9300.0, 0.13332)), new(0.00888d, new GammaParticle(27510.0, 0.04507)), new(0.01073d, new GammaParticle(28780.0, 0.04308)), new(0.0555d, new GammaParticle(31780.0, 0.03901)), new(0.000814d, new GammaParticle(32610.0, 0.03802)), new(0.1258d, new GammaParticle(35802.0, 0.03463)), new(0.37d, new GammaParticle(68170.0, 0.01819)), new(0.2664d, new GammaParticle(100880.0, 0.01229)), new(0.2935806406848d, new GammaParticle(6603.0, 0.18777)), new(0.08084213325986238d, new GammaParticle(40901.0, 0.03031)), new(0.14587176697918147d, new GammaParticle(41541.0, 0.02985)), new(0.0459555203187251d, new GammaParticle(47146.0, 0.0263)), new(0.05781204456095618d, new GammaParticle(47645.0, 0.02602)), new(0.011856524242231077d, new GammaParticle(48248.0, 0.0257)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    