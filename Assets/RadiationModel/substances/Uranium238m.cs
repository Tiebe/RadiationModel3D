using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium238m : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium238m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 238.05353d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9740000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium238()), new(0.32d, new GammaParticle(1879000.0, 0.00066)), new(0.65d, new GammaParticle(2512700.0, 0.00049)), new(0.00068222152d, new GammaParticle(16678.0, 0.07434)), new(0.00040404534441015205d, new GammaParticle(94657.0, 0.0131)), new(0.000646783006899555d, new GammaParticle(98439.0, 0.0126)), new(0.00023334340438918978d, new GammaParticle(111238.0, 0.01115)), new(0.0003131468486902927d, new GammaParticle(112645.0, 0.01101)), new(7.980344430110292e-05d, new GammaParticle(114446.0, 0.01083)) } },
            { 0.026000000000000002d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    