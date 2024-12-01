using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten178 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten178";
        public override double halfLife { get; } = 1866240.0d;
        public override double atomicWeight { get; } = 177.94589d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum178()), new(0.20264544d, new GammaParticle(9424.0, 0.13156)), new(0.0712112283618939d, new GammaParticle(56280.0, 0.02203)), new(0.12414788766020556d, new GammaParticle(57535.0, 0.02155)), new(0.041071562187323274d, new GammaParticle(65315.0, 0.01898)), new(0.05216088397790055d, new GammaParticle(66067.0, 0.01877)), new(0.011089321790577282d, new GammaParticle(66981.0, 0.01851)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    