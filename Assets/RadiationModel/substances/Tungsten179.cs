using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten179 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten179";
        public override double halfLife { get; } = 2223.0d;
        public override double atomicWeight { get; } = 178.94708d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium179() }, { 1.0d, new BetaParticle(1, 584000.0) }, { 0.18d, new GammaParticle(30700.0, 0.04039) }, { 0.001062d, new GammaParticle(133900.0, 0.00926) }, { 0.28874708273664d, new GammaParticle(9424.0, 0.13156) }, { 0.22397644771525754d, new GammaParticle(56280.0, 0.02203) }, { 0.39047497858308494d, new GammaParticle(57535.0, 0.02155) }, { 0.12917994552886417d, new GammaParticle(65315.0, 0.01898) }, { 0.16405853082165747d, new GammaParticle(66067.0, 0.01877) }, { 0.03487858529279333d, new GammaParticle(66981.0, 0.01851) } } },

        };
    }
}
    