using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum182n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum182n";
        public override double halfLife { get; } = 950.4d;
        public override double atomicWeight { get; } = 181.95071d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum182()), new(2.256e-05d, new GammaParticle(16273.0, 0.07619)), new(0.36479999999999996d, new GammaParticle(146785.0, 0.00845)), new(0.48d, new GammaParticle(171586.0, 0.00723)), new(0.24d, new GammaParticle(184951.0, 0.0067)), new(0.0672d, new GammaParticle(318400.0, 0.00389)), new(0.0028799999999999997d, new GammaParticle(356470.0, 0.00348)), new(0.57979132376064d, new GammaParticle(9424.0, 0.13156)), new(0.26895126843391093d, new GammaParticle(56280.0, 0.02203)), new(0.4688829644942659d, new GammaParticle(57535.0, 0.02155)), new(0.15511948046600255d, new GammaParticle(65315.0, 0.01898)), new(0.19700174019182323d, new GammaParticle(66067.0, 0.01877)), new(0.04188225972582069d, new GammaParticle(66981.0, 0.01851)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    